using AbstrataCliente;


Teste teste = new Teste();
ClienteFisico cf = new ClienteFisico(1, "Marcoh","MarcohHouse", 222, 28, "98");
ClienteJuridico cj = new ClienteJuridico(1, "Abc","AbcHouse", 444, 12, "101");

teste.VerificaIdade(cf);