using Arvore;

var nodeFather = new Node("A", true);
var nodeSon1 = new Node("B", false);
var nodeSon2 = new Node("C", false);
var nodeSon3 = new Node("D", false);
var nodeSon4 = new Node("E", false);
var nodeSon5 = new Node("F", false);
var nodeSon6 = new Node("G", false);
var nodeSon7 = new Node("H", false);

nodeFather.InsertSon(nodeSon1);
nodeFather.InsertSon(nodeSon2);
nodeSon1.InsertSon(nodeSon3);
nodeSon2.InsertSon(nodeSon4);
nodeSon3.InsertSon(nodeSon5);
nodeSon4.InsertSon(nodeSon6);
nodeSon6.InsertSon(nodeSon7);

var tree = new Tree(nodeFather);

////Para realizar o teste basta trocar o parâmetro o valor da variavel 'parametro'
var parametro = nodeFather;

//Print da Árvore Completa
Console.WriteLine("Árvore Completa");
tree.ShowTree(nodeFather);


Console.WriteLine(new string('-', 40));
////Print para saber se é folha
if (tree.isLeaf(parametro))
{
    Console.WriteLine($"O nó {parametro.Name} é folha");
}
else
{
    Console.WriteLine($"O nó {parametro.Name} não é folha");
}


Console.WriteLine(new string('-', 40));
//Print para saber o nível; Lembrar de trocar o parâmetros dos prints 
Console.WriteLine($"O nível do nó {parametro.Name} é {tree.NodeLevel(parametro)}");


Console.WriteLine(new string('-', 40));
//Print para saber a profundidade; Lembrar de trocar o parâmetros dos prints 
Console.WriteLine($"A profundidade de {parametro.Name} é {tree.NodeLevel(parametro)}");

Console.WriteLine(new string('-', 40));
//Altura é por dimensão você conta a partir de 1 a não ser que não exista no caso de só tem a raiz
Console.WriteLine($"A altura de {parametro.Name} é {tree.NodeHeight(parametro)}");

Console.WriteLine(new string('-', 40));
//Print para saber o grau; Lembrar de trocar o parâmetros dos prints 
Console.WriteLine($"O grau de {parametro.Name} é {tree.NodeDegree(parametro)}");

Console.WriteLine(new string('-', 40));
//Print da subárvore; Lembrar de trocar o parâmetros dos prints
tree.PrintSubTree(parametro);



