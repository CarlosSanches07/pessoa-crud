using System.Collections.Generic;
using pessoa_crud.Domain;
using System.Linq;

namespace pessoa_crud.Repository {
    public class PessoaRepository {
        public static List<Pessoa> Listar() {
            using(var db = new PessoaContext()) {
                return db.Pessoas.OrderBy(p => p.id).ToList();
            }
        }

        public static void Salvar(Pessoa p) {
            using(var db = new PessoaContext()) {
                db.Add(p);
                db.SaveChanges();
            }
        }

        public static void Atualizar(Pessoa p) {
            using(var db = new PessoaContext()) {
                var pessoa = db.Pessoas.First(f => f.id == p.id);
                pessoa.nome = p.nome;
                pessoa.email = p.email;
                pessoa.senha = p.senha;
                pessoa.telefone = p.telefone;
                pessoa.nascimento = p.nascimento;
                db.Pessoas.Update(pessoa);
                db.SaveChanges();
            }
        }

        public static void Excluir(long id) {
            using(var db = new PessoaContext()) {
                var pessoa = db.Pessoas.First(f => f.id == id);
                db.Pessoas.Remove(pessoa);
                db.SaveChanges();
            }
        }
    }
}