## API Pessoa

### Rota /Pessoa
- *Get* - Lista todas as pessoas cadastradas;
- *Post* - Cadastra uma nova pessoa, todos os dados da pessoa devem ser
preenchidos, os dados devem ser transmitidos pelo corpo da requisição;
	-  Dados
		- nome:string
		- senha:string
		- email:string
		- telefone:string
		- aniversario:DateTime
- *Put* - Atualiza os dados da pessoa informada pelo corpo da requisição, os dados são os mesmos do *Post* com a adição do ID;
	-  Dados
		- id:long
		- nome:string
		- senha:string
		- email:string
		- telefone:string
		- aniversario:DateTime
- *Delete* - Realiza a exclusão do item cujo id foi informado pela URL da requisição;
	- Exemplo
			 https://localhost:1010/Pessoa?id=1
