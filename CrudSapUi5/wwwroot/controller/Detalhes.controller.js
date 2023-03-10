sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/core/routing/History",
	"sap/ui/model/json/JSONModel",
	"sap/m/MessageBox",
	"../servicos/Repositorio.controller"

], function (Controller, History, JSONModel, MessageBox, Repositorio) {
	"use strict";

	return Controller.extend("sap.ui.demo.walkthrough.controller.Detalhes", {

		rota: null,
		onInit: function () {
			this.rota = this.getOwnerComponent().getRouter();
			this.rota.getRoute("detalhes").attachPatternMatched(this.ajustarRota, this);
		},

		ajustarRota: function (evento) {
			var mostrarDetalhes = evento.getParameter("arguments").id;
			this.buscarLivroDaLista(mostrarDetalhes);
		},

		buscarLivroDaLista: function (livroASerExibido) {
			const nomeDoModelo = "livro";
			let repositorio = new Repositorio;
			repositorio.buscarLivroPorId(livroASerExibido)
				.then(lista => {
					let oModel = new JSONModel(lista);
					this.getView().setModel(oModel, nomeDoModelo)
				})
		},


		aoClicarEmVoltar: function () {
			var oHistory = History.getInstance();
			var sPreviousHash = oHistory.getPreviousHash();
			if (sPreviousHash !== undefined) {
				window.history.go(-1);
			} else {
				this.rota.navTo("overview", {});
			}
		},

		aoClicarEmDeletar: function () {
			const rotaDaLista = "overview";
			let excluirLivro = this.getView().getModel("livro").getData().codigo
			let repositorio = new Repositorio;
			MessageBox.confirm("Deseja realmente deletar esse livro?", {
				title: "Confirmação",
				emphasizedAction: sap.m.MessageBox.Action.OK,
				actions: [sap.m.MessageBox.Action.OK,
					sap.m.MessageBox.Action.CANCEL
				],
				onClose: function (oAction) {
					if (oAction === 'OK') {
					 repositorio.deletarLivro(excluirLivro);
					 this._navegarParaLista(rotaDaLista, null)
					}					
				}.bind(this)
				
			});
			// repositorio.deletarLivro(excluirLivro);
			// alert("deletado")
			// this.rota.navTo("overview", {
			// 	id: excluirLivro

			// });
		},
		

		_navegarParaLista(nomeDaRota, codigo) {
			let rota = this.getOwnerComponent().getRouter();

			if(codigo !== null){
				rota.navTo(nomeDaRota, {
					"codigo" : codigo
				})
			}else{
				rota.navTo(nomeDaRota)
			}
		},


		aoClicarEmEditar: function () {
			let idEditarLivro = this.getView().getModel("livro").getData().codigo
			this.rota.navTo("editarLivro", {
				id: idEditarLivro

			});
		}

	});
})