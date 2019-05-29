using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatePark.Models;
using StatePark.Repositories;

namespace StatePark.Controllers
{
    public class Atividade : Controller
    {
        public IActionResult NovaEntrada(IFormCollection form){
            var carroModel = new CarroModel(
                placa:form["placaCarro"],
                marca:form["marcaCarro"],
                modelo:form["modeloCarro"]
            );
            var condutorModel = new CondutorModel(
                carro:carroModel,
                nomeCondutor:form["nomeCondutor"]
            );
            var atividade = new AtividadeModel(
                condutor:condutorModel,
                carro:carroModel
            );
            AtividadeRepository.InserirAtividade(atividade);

            var listas = new AtividadeModel(
                listaDeMarcas:AtividadeRepository.ListarMarcas(),
                listaDeModelos:AtividadeRepository.ListarModelos()
            );
            return View(listas); //Redirecionar para uma tela de sucesso
        }
        public IActionResult BalancoDeAtividade(){
            
            return View();
        }
        // public IActionResult OrganizarBalancoDeAtividade(string parametro){
        //     return View();
        // } Fazer método que organize a lista de acordo com a preferência do usuário
    }
}