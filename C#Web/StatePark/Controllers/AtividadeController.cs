using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatePark.Models;
using StatePark.Repositories;
using StatePark.ViewModels;

namespace StatePark.Controllers {
    public class Atividade : Controller {
        public IActionResult NovaEntrada () {

            var listas = new AtividadeViewModel (
                listaDeAtividades: AtividadeRepository.ListarAtividades (),
                listaDeMarcas: AtividadeRepository.ListarMarcas (),
                listaDeModelos: AtividadeRepository.ListarModelos ()
            );
            ViewData["ViewName"] = "Nova Entrada";
            return View (listas); //Redirecionar para uma tela de sucesso
        }
        public IActionResult RegistrarAtividade (IFormCollection form) {
            var carroModel = new CarroModel (
                placa: form["placaCarro"],
                marca: form["marcaCarro"],
                modelo: form["modeloCarro"]
            );
            var condutorModel = new CondutorModel (
                carro: carroModel,
                nomeCondutor: form["nomeCondutor"]
            );
            var atividade = new AtividadeModel (
                condutor: condutorModel,
                carro: carroModel
            );
            AtividadeRepository.InserirAtividade (atividade);
            ViewData["ViewName"] = "Nova Entrada";
            return RedirectToAction("NovaEntrada");
        }
        public IActionResult BalancoDeAtividade () {
            AtividadeViewModel listas = new AtividadeViewModel (
                listaDeAtividades: AtividadeRepository.ListarAtividades (),
                listaDeMarcas: AtividadeRepository.ListarMarcas (),
                listaDeModelos: AtividadeRepository.ListarModelos ()
            );
            ViewData["ViewName"] = "Balanço de Atividade";
            return View (listas);
        }
        // public IActionResult OrganizarBalancoDeAtividade(string parametro){
        //     return View();
        // } Fazer método que organize a lista de acordo com a preferência do usuário
    }
}