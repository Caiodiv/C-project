using RestApiModelDDD.Domain.Entitys;
using RestApiModeloDDD.Aplicativo.Dtos;

namespace RestApiModelDDD.Infrastructure.CrossCutting.Interface
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}
