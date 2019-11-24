using System;
using System.Collections.Generic;
using System.Linq;
using Gma.System.MouseKeyHook.Implementation;

namespace Gma.System.MouseKeyHook
{
    public static class KeyCombinationExtensions
    {
        public static void OnCombination(this IKeyboardEvents source,
            IEnumerable<KeyValuePair<Combination, Action>> map, Action reset = null)
        {
            var watchlists = map.GroupBy(k => k.Key.TriggerKey)
                .ToDictionary(g => g.Key, g => g.ToArray());
            source.KeyDown += (sender, e) =>
            {
                KeyValuePair<Combination, Action>[] element;
                var found = watchlists.TryGetValue(e.KeyCode, out element);
                if (!found)
                {
                    reset?.Invoke();
                    return;
                }
                var state = KeyboardState.GetCurrent();
                var action = reset;
                var maxLength = 0;
                foreach (var current in element)
                {
                    var matches = current.Key.Chord.All(state.IsDown);
                    if (!matches) continue;
                    if (maxLength > current.Key.ChordLength) continue;
                    maxLength = current.Key.ChordLength;
                    action = current.Value;
                }
                action?.Invoke();
            };
        }

        public static void OnSequence(this IKeyboardEvents source, IEnumerable<KeyValuePair<Sequence, Action>> map)
        {
            var actBySeq = map.ToArray();
            var endsWith = new Func<Queue<Combination>, Sequence, bool>((chords, sequence) =>
            {
                var skipCount = chords.Count - sequence.Length;
                return skipCount >= 0 && chords.Skip(skipCount).SequenceEqual(sequence);
            });

            var max = actBySeq.Select(p => p.Key).Max(c => c.Length);
            var min = actBySeq.Select(p => p.Key).Min(c => c.Length);
            var buffer = new Queue<Combination>(max);

            var wrapMap = actBySeq.SelectMany(p => p.Key).Select(c => new KeyValuePair<Combination, Action>(c, () =>
            {
                buffer.Enqueue(c);
                if (buffer.Count > max) buffer.Dequeue();
                if (buffer.Count < min) return;
                //Invoke action corresponding to the longest matching sequence
                actBySeq
                    .Where(pair => endsWith(buffer, pair.Key))
                    .OrderBy(pair => pair.Key.Length)
                    .Select(pair => pair.Value)
                    .LastOrDefault()
                    ?.Invoke();
            }));

            OnCombination(source, wrapMap, buffer.Clear);
        }
    }
}