

using Store.Enums;

namespace Store.Contracts
{
    public interface IClothes
    {
        Size Size { get; }

        string Color { get; }
    }
}
