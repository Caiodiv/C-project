using RestApiModelDDD.Domain.Entitys;
using RestApiModeloDDD.Aplicativo.Dtos;

namespace RestApiModelDDD.Infrastructure.CrossCutting.Interface
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
