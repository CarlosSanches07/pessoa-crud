using Microsoft.AspNetCore.Mvc;
using pessoa_crud.Business;
using pessoa_crud.Domain;

namespace pessoa_crud.Controllers {
     [ApiController]
     [Route("[controller]")]
     public class PessoaController: ControllerBase {
        
        [HttpGet]
        public JsonResult Get() {     
            return new JsonResult(PessoaBusiness.Listar());
        }

        [HttpPost]
        public JsonResult Post(Pessoa pessoa) {
            return new JsonResult(PessoaBusiness.Salvar(pessoa));
        }

        [HttpPut]
        public JsonResult Put(Pessoa pessoa){
            return new JsonResult(PessoaBusiness.Atualizar(pessoa));
        }

        [HttpDelete]
        public JsonResult Delete([FromQuery(Name = "id")]long id) {
            return new JsonResult(PessoaBusiness.Excluir(id));
        } 
     }
 }