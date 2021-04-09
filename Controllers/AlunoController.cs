using api.Data.Collections;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Linq;



namespace api.Controllers
{

    [Route("aluno")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        Api.Data.MongoDB _mongoDB;

        IMongoCollection<Aluno> _alunosCollection;


        public AlunoController(Api.Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _alunosCollection = _mongoDB.DB.GetCollection<Aluno>(typeof(Aluno).Name.ToLower());
        }


        [HttpGet]
        public ActionResult ListaDeAlunos()
        {
            var alunos = _alunosCollection.Find(Builders<Aluno>.Filter.Empty).ToList();

            return Ok(alunos);
        }

        [HttpPost]
        public ActionResult SalvarAluno([FromBody]AlunoDto dto)
        {
            var aluno = new Aluno(dto.Matricula, dto.Nome, dto.Curso, dto.Periodo, dto.anoIngresso);

            _alunosCollection.InsertOne(aluno);

            return StatusCode(201, "Aluno adicionado com sucesso");
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{matricula}")]
        public ActionResult Delete(int matricula)
        {
            _alunosCollection.DeleteOne(Builders<Aluno>.Filter.Where(_ => _.Matricula == matricula));

            return Ok("Deletado com sucesso");
        }
    }
}
