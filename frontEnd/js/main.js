import TableCsv from "./TableCsv.js";

//associa a tabela a DOM do navegador e utilizamos o seletor de requisição;
//(csvRoot) é o id da tabela contida na pagina indx.html;
const tableRoot = document.querySelector("#csvRoot");

//instancia de um novo objeto TableCsv -- importamos na linha 1
//tableRoot como parametro
const tableCsv = new TableCsv(tableRoot);

//declaramos quais sao titulos dos atributos
tableCsv.setHeader( [ "CIDADE","Categorias da capacidade",	"JANELA","SEGMENTO", "DATA_1","Cota", "Atividades Reservadas",	"Usado",	"DATA2",	"Cota",	"Atividades Reservadas",	"Usado",	"DATA3",	"Cota",	"Atividades Reservadas",	"Usado",	"DATA4",	"Cota",	"Atividades Reservadas",	"Usado",	"DATA5",	"Cota",	"Atividades Reservadas",	"Usado",	"DATA6",	"Cota",	"Atividades Reservadas",	"Usado",	"DATA7",	"Cota",	"Atividades Reservadas", "Usado" ] );