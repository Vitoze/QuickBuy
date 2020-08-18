import { Component } from "@angular/core"

@Component({
  selector: "produto",
  template: "<html><body>{{ obterNome() }}</body></html>"
})
export class ProdutoComponent { // Nome das classes comecando com maiusculo por conta da convencao PascalCase

  /* camelCase para variaveis, atributos e nomes das funcoes  */
  public nome: string;
  public disponivelParaVenda: boolean;

  public obterNome(): string {
    return "Samsung";
  }
}
