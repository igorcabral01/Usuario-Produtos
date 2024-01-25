using Usuario.models;
using Usuario.Products;
AdicionarProdutos adc = new AdicionarProdutos()
;
CadastroUsuarios cad = new CadastroUsuarios();
cad.CadastraUsuarios();
cad.Login();
cad.AutenticarUsuario();
//  cad.ListarUsuario();
adc.AdcProdut();
