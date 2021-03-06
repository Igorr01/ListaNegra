using System;
using System.Collections.Generic;

namespace backend.Ultils
{
    public class ConversorListaNegra
    {
        public Models.TbListaNegra ParaTabela(Models.Request.ListaNegraRequest request)
        {
            Models.TbListaNegra ln = new Models.TbListaNegra();
            ln.NmPessoa = request.Nome;
            ln.DsMotivo = request.Motivo;
            ln.DtInclusao = DateTime.Now;

            return ln;
        }

        public Models.Response.ListaNegraResponse ParaResponse(Models.TbListaNegra ln)
        {
            Models.Response.ListaNegraResponse resp =new Models.Response.ListaNegraResponse();
            resp.Id = ln.IdListaNegra;
            resp.Nome = ln.NmPessoa;
            resp.Motivo = ln.DsMotivo;
            resp.Inclusao = ln.DtInclusao;
            return resp;
        }

        public List<Models.Response.ListaNegraResponse> ParaResponse(List<Models.TbListaNegra> lns)
        {
            List<Models.Response.ListaNegraResponse> resp = new List<Models.Response.ListaNegraResponse>();
            foreach (Models.TbListaNegra item in lns)
            {
                resp.Add(
                    this.ParaResponse(item));
            }
            return resp;
        }
    }
}


