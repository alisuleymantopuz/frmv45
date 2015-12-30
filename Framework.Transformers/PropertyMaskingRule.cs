
namespace Framework.Transformers
{
    public class PropertyMaskingRule<T>
    {
        public int HowManyEarlyDigistShouldNotToBeMask { get; set; }

        public int HowManyLastDigistShouldNotToBeMask { get; set; }
    }
}
