using Cafe.DI.DataInterfaces;
using Cafe.DI.Enums;

namespace Cafe.DI.ModelInterfaces
{
    public interface IMeal:IData<(TypeOfProduct,string)>
    {
        void Reset();
    }
}
