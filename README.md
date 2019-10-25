# Projeto Espelho para API de Filmes


## Diagrama do Projeto Filmes (Prova)

<p align="center">
    <img alt="Diagrama" src="/Documentos/diagrama.png" width="600" />
</p>


## Explicação do Projeto

**Explicação por Flavio:** https://drive.google.com/drive/folders/1PuQeWEhY0HxGG-eVv2vC8NwNvZUxn07Q


### Construíndo o projeto 
**Roteiro para construir o projeto espelho baseado na API de Investidor**

1. Preparar a estrutura MVVC do projeto.
2. Configurar o SQLite no Android, iOS e projeto principal.
3. Preparar MasterDetailPage (Multiplas navegaçoes com MessagingCenter), é preciso adicionar as páginas PrincipalPage e MenuPage.
6. Preparar o ListView na MoedaPage e Receber a API de Moedas pelas Classes: MoedaService e MoedaViewModel.
7. Preparar nova página que exibe as moedas selecionadas (fora de ordem). Além disso, preparar o botão para cadastro no banco e abrir nova pagina (MoedasSelecionadasPage, MoedasSelecionadasViewModel).
7. Prepara o Rank de Moedas pela Cotação do Dolar (MoedasRankViewModel e MoedasRankPage).
8. Pagina final com os detalhes da moeda (MoedaDetalhePage e MoedaDetalheViewMoedel). Realiza requisição na API e retorna os dados da moeda. Além disso, códigos de QRCode e Gráficos serão mocados para todas as moedas (Necessário adicionar códigos na classe MainActivity.cs).

**Não esqueça de baixar as dependências do projeto, caso necessário**

* Newtonsoft.Json
* OxyPlot.Xamarin.Forms
* SQLite
* sqlite-net-pcl
* ZXing.Net.Mobile
* ZXing.Net.Mobile.Forms