﻿using RestApiModeloDDD.Aplicativo.Dtos;

namespace RestApiModeloDDD.Aplicativo.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);
        void Update(ProdutoDto produtoDto);
        void Delete(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto GetById(int id);
    }
}
