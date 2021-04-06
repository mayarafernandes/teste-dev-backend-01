using Owner.BinaryTree;

namespace Owner.JogoGourmet.KnowledgeBase
{
    public class KnowledgeBaseBinaryTree : IKnowledgeBase<string>
    {
        private BinaryTree<string> _binaryTree;
        private BinaryTreeNode<string> _currentNode;

        public KnowledgeBaseBinaryTree()
        {
            InitializeBinaryTree();
            _currentNode = _binaryTree.RootNode;
        }

        public string CurrentItem
        {
            get
            {
                return _currentNode.Data;
            }
        }

        public string FirstCategory 
        { 
            get 
            {
                _currentNode = _binaryTree.RootNode;
                return _currentNode.Data;
            } 
        }

        public string FirstDish
        {
            get
            {
                _currentNode = _currentNode.RightNode;
                return _currentNode.Data;
            }
        }

        public bool IsCurrentItemDish
        {
            get
            {
                return _currentNode.RightNode is null;
            }
        }

        public string NextItem 
        { 
            get 
            {
                _currentNode = _currentNode.LeftNode;
                return _currentNode.Data;
            }
        }

        public bool HasNextItem 
        { 
            get 
            { 
                return _currentNode.LeftNode != null; 
            }
        }

        public void AddItem(string dish, string category = null)
        {
            if (category is null)
                _currentNode.LeftNode = new BinaryTreeNode<string>(dish);
            else
                _currentNode.LeftNode = new BinaryTreeNode<string>(category, null, new BinaryTreeNode<string>(dish));
        }

        private void InitializeBinaryTree()
        {
            BinaryTreeNode<string> lasanhaNode = new BinaryTreeNode<string>("Lasanha");
            BinaryTreeNode<string> boloChocolateNode = new BinaryTreeNode<string>("Bolo de Chocolate");
            BinaryTreeNode<string> boloNode = new BinaryTreeNode<string>("Bolo", null, boloChocolateNode);
            BinaryTreeNode<string> massaNode = new BinaryTreeNode<string>("Massa", boloNode, lasanhaNode);
            _binaryTree = new BinaryTree<string>(massaNode);
        }
    }
}
