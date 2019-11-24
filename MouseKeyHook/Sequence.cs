using System.Linq;

namespace Gma.System.MouseKeyHook
{
    public class Sequence : SequenceBase<Combination>
    {
        private Sequence(Combination[] combinations) : base(combinations)
        {
        }

        public static Sequence Of(params Combination[] combinations)
        {
            return new Sequence(combinations);
        }

        public static Sequence FromString(string text)
        {
            var parts = text.Split(',');
            var combinations = parts.Select(Combination.FromString).ToArray();
            return new Sequence(combinations);
        }
    }
}