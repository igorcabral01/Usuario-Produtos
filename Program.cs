using Usuario.models;
using Usuario.Products;
AdicionarProdutos adc = new AdicionarProdutos(2,5,13);
CadastroUsuarios cad = new CadastroUsuarios(2,5,13);
cad.CadastraUsuarios();
cad.Login();
cad.AutenticarUsuario();
//  cad.ListarUsuario();
// adc.AdcProdut();