using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.Implementation;

namespace Gma.System.MouseKeyHook
{
    public class Combination
    {
        private readonly Chord _chord;

        private Combination(Keys triggerKey, IEnumerable<Keys> chordKeys)
            : this(triggerKey, new Chord(chordKeys))
        {
        }

        private Combination(Keys triggerKey, Chord chord)
        {
            TriggerKey = triggerKey.Normalize();
            _chord = chord;
        }
        public Keys TriggerKey { get; }

        public IEnumerable<Keys> Chord
        {
            get { return _chord; }
        }

        public int ChordLength
        {
            get { return _chord.Count; }
        }

        public static Combination TriggeredBy(Keys key)
        {
            return new Combination(key, (IEnumerable<Keys>) new Chord(Enumerable.Empty<Keys>()));
        }

        public Combination With(Keys key)
        {
            return new Combination(TriggerKey, Chord.Concat(Enumerable.Repeat(key, 1)));
        }

        public Combination Control()
        {
            return With(Keys.Control);
        }

        public Combination Alt()
        {
            return With(Keys.Alt);
        }

        public Combination Shift()
        {
            return With(Keys.Shift);
        }

        public override string ToString()
        {
            return string.Join("+", Chord.Concat(Enumerable.Repeat(TriggerKey, 1)));
        }

        public static Combination FromString(string trigger)
        {
            var parts = trigger
                .Split('+')
                .Select(p => Enum.Parse(typeof(Keys), p))
                .Cast<Keys>();
            var stack = new Stack<Keys>(parts);
            var triggerKey = stack.Pop();
            return new Combination(triggerKey, stack);
        }

        protected bool Equals(Combination other)
        {
            return
                TriggerKey == other.TriggerKey
                && Chord.Equals(other.Chord);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Combination) obj);
        }

        public override int GetHashCode()
        {
            return Chord.GetHashCode() ^
                   (int) TriggerKey;
        }
    }
}