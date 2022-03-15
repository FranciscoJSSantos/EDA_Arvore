namespace Arvore
{
    public class Tree
    {
        public Tree(Node root)
        {
            NodeRoot = root;
        }

        public Node NodeRoot { get; set; }

        public void ShowTree(Node node)
        {
            // Printa a árvore e os seus nós indicando quais estão na esquerda e direita;
            while (true)
            {
                Console.WriteLine(node.Name);

                if (node.LeftNode != null)
                {
                    Console.WriteLine("Nó esquerdo: ");
                    ShowTree(node.LeftNode);
                }
                if (node.RightNode != null)
                {
                    Console.WriteLine("Nó direito: ");
                    ShowTree(node.RightNode);

                }

                break;
            }
        }

        public bool isLeaf(Node node)
        {
            // Verifica de o nó escolhido possui filho na esquerda e na direita, se possuir retorna 'true', se não 'false';
            if(node.LeftNode == null && node.RightNode == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int NodeLevel(Node node)
        {
            // Nível do nó escolhido
            return node.Level;
        }

        public int NodeDepth(Node node)
        {
            //Por ser uma árvore binária temos como profundidade de um nó o comprimento do caminho da raiz até o nó;
            var profundidade = 0;
            if(node.Father != null)
            {
                ++profundidade; 
                return profundidade;
            }
            
            return profundidade;
        }

        public int NodeHeight(Node node)
        {
            if(node.LeftNode == null && node.RightNode == null)
            {
                return 0;
            }
            else
            {
                //Mudar o valor do 'left' e 'right' acordo com o tipo de contagem que você fizer; se for por nós começa com 1; se for por arestas começa com 0
                int left = 1;
                int right = 1;

                if (node.LeftNode != null)
                {
                    left = NodeHeight(node.LeftNode);
                }


                if (node.RightNode != null)
                {
                    right = NodeHeight(node.RightNode);
                }

                if (left > right)
                {
                    return (left + 1);
                }
                else
                {
                    return (right + 1);
                }
            }
        }


        public int NodeDegree(Node node)
        {
            //Como a árvore é binária temos essas três situações: se for o nó folha não possui grau; se possuir um filho tem grau 1; se possuir dois filhos tem grau 2;
            if(isLeaf(node) == true)
            {
                return 0;
            }
            else if (node.LeftNode == null || node.RightNode == null)
            {
                return 1;
            }
            else
            {
               return 2;
            }
        }

        public void PrintSubTree(Node node)
        {
            //Verificando se é nó folha ou se possui uma sub árvore
            if (isLeaf(node)) 
            {
                Console.WriteLine($"Não existe sub árvores para o nó {node.Name}");
            }
            else
            {
                Console.WriteLine($"Existe sub árvores para o nó {node.Name}:");
                Console.WriteLine(" ");
            }

            //Printa a sub árvore da acordo com o nó selecionado
            if (node.LeftNode != null)
            {
                Console.WriteLine($"sub árvore da esquerda de {node.Name}");
                ShowTree(node.LeftNode);
                Console.WriteLine(" ");
            }
                   
            if (node.RightNode != null)
            {
                Console.WriteLine($"sub árvore da direita de {node.Name}");
                ShowTree(node.RightNode);
                Console.WriteLine(" ");
            }    

        }
    }
}

