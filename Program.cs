using Usuario.models;
PaginaLogin pag = new PaginaLogin();
PaginaLogin log = new PaginaLogin();

Console.WriteLine("Ola, Seja BEM VINDO ao MercadoOnline! \n Digite as informaçoes abaixo para efetuar seu Cadastro");

Console.WriteLine("Digite seu usuario");
pag.Usuario = Console.ReadLine();
Console.WriteLine("Digite sua senha");
pag.Senha = Console.ReadLine();
Console.WriteLine("Digite seu email");
pag.Email = Console.ReadLine();

pag.CadastraUsuario();
log.ConferirLogin();




