//Classe destinada a implementação dos dados obtidos do arquivo csv
export default class
{
    /**
     * @param {HTMLTableElement} root o elemento tabela com os dados do arquivo csv
     */

    
    
    constructor(root)
    {
        //importar na classe main
        this.root = root;
        console.log("root ok");

        //teste de retorno no console - browser -- RETORNO - OK 
        //console.log("Eu sou um construtor!")
    }

    /**
   * Sets the table header.
   *
   * @param {string[]} headerColumns List of headings to be used
   */
  setHeader(headerColumns) {
    this.root.insertAdjacentHTML(
      "afterbegin",
      `
            <thead>
                <tr>
                    ${headerColumns.map((text) => `<th>${text}</th>`).join("")}
                </tr>
            </thead>
        `
    );
  }
}


