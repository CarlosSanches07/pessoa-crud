using System.Collections.Generic;
using System.Linq;
using pessoa_crud.Domain;
using pessoa_crud.Repository;

namespace pessoa_crud.Business {
    public class PessoaBusiness {
        public static List<Pessoa> Listar() {
            return PessoaRepository.Listar();
        }

        public static string Salvar(Pessoa p) {
            if(verifyData(p)){
                PessoaRepository.Salvar(p);
                return "Salvo com sucesso";
            } else {
                return "Preencha todos os dados";
            }
        }

        public static string Atualizar(Pessoa p) {
            if(verifyId(p.id)) {
                if(verifyData(p)){
                    PessoaRepository.Atualizar(p);
                    return "Atualizado com sucesso";
                } else {
                    return "Preencha todos os dados";
                }
            } else {
                return "Id inválido";
            }
        }

        public static Pessoa Buscar(long id) {
            if(verifyId(id))
                return Listar().Find(f => f.id == id);
            return null;
        }

        public static string Excluir(long id) {
            if(verifyId(id)) {
                PessoaRepository.Excluir(id);
                return "Pessoa excluida";
            }
            return "Id invalído";
        }

        private static bool verifyId(long id) {
            return Listar().Any(a => a.id == id);
        }

        private static bool verifyData(Pessoa p ) {
            return (
                !string.IsNullOrWhiteSpace(p.nome) ||
                !string.IsNullOrWhiteSpace(p.senha) ||
                !string.IsNullOrWhiteSpace(p.telefone) ||
                !string.IsNullOrWhiteSpace(p.email)
            );
        }
    }
}