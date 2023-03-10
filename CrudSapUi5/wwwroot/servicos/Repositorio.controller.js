sap.ui.define([
    "sap/ui/core/mvc/Controller"
	
], function(Controller) {
    'use strict';
    
    return Controller.extend("sap.ui.demo.walkthrough.controller.Repositorio",{

        buscarTodosOsLivros: async function(){
            let ObterTodosOsLivros;
			 await fetch(`https://localhost:7037/CrudLivro`)
			.then(response => response.json())
			.then(data => ObterTodosOsLivros = data)
			return ObterTodosOsLivros;
        },

        buscarLivroPorId: function (idLivroBuscado) {
            let livroBuscado = fetch(`https://localhost:7037/CrudLivro/${idLivroBuscado}`)
                .then((response) => response.json())
                .then(data => livroBuscado = data)
            return livroBuscado;
        },


        cadastrarLivro: async function(livroAserSalvo){
			let livroASerCadastrado = livroAserSalvo;
			await fetch('https://localhost:7037/CrudLivro', {
				method: 'POST',
				headers: {
					'content-type': "application/json; charset=utf-8"
				},
				
				body: JSON.stringify({
					nome: livroASerCadastrado.nome,
					autor: livroASerCadastrado.autor,
					editora: livroASerCadastrado.editora,
					anoPublicacao: livroASerCadastrado.anoPublicacao,
				}) 
			})	
        },

        editarLivro: async function(livroEditado){
			let livroASerEditado = livroEditado;
			await fetch(`https://localhost:7037/CrudLivro/${livroASerEditado.codigo}`, {
					method: 'PUT',
					headers: {
						"Content-Type": "application/json; charset=utf-8"
					},	
				    body: JSON.stringify({		
				            nome: livroASerEditado.nome,
				            autor: livroASerEditado.autor,
				            editora: livroASerEditado.editora,
				            anoPublicacao: livroASerEditado.anoPublicacao,
					})
				})
           },


           deletarLivro: async function (excluirLivro) {
			excluirLivro.codigo;
            await fetch(`https://localhost:7037/CrudLivro/${excluirLivro}`, {
                method: 'DELETE'
            })
        }

    });

});