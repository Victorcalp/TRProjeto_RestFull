using System.Collections.Generic;

namespace TRProjeto_RestFull.Data.Converter.Contract
{
    public interface IParser<O,D>
    {
        D Parse(O item);

        List<D> Parse(List<O> items);
    }
}
