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

//Print da Árvore Completa
Console.WriteLine("Árvore Completa");
tree.ShowTree(nodeFather);



Console.WriteLine(new string('-', 40));
////Print para saber se é folha
////Para realizar o teste basta trocar o parâmetro da função "isLeaf()" e dos prints
if (tree.isLeaf(nodeSon5))
{
    Console.WriteLine($"O nó {nodeFather.Name} é folha");
}
else
{
    Console.WriteLine($"O nó {nodeFather.Name} não é folha");
}


Console.WriteLine(new string('-', 40));
//Print para saber o nível; Lembrar de trocar o parâmetros dos prints 
Console.WriteLine($"O nível do nó {nodeFather.Name} é {tree.NodeLevel(nodeFather)}");


Console.WriteLine(new string('-', 40));
//Print para saber a profundidade; Lembrar de trocar o parâmetros dos prints 
Console.WriteLine($"A profundidade de {nodeFather.Name} é {tree.NodeLevel(nodeFather)}");

Console.WriteLine(new string('-', 40));
//Altura é por dimensão você conta a partir de 1 a não ser que não exista no caso de só tem a raiz
Console.WriteLine($"A altura de {nodeFather.Name} é {tree.NodeHeight(nodeFather)}");

Console.WriteLine(new string('-', 40));
//Print para saber o grau; Lembrar de trocar o parâmetros dos prints 
Console.WriteLine($"O grau de {nodeFather.Name} é {tree.NodeDegree(nodeFather)}");

Console.WriteLine(new string('-', 40));
//Print da subárvore; Lembrar de trocar o parâmetros dos prints
tree.PrintSubTree(nodeFather);



