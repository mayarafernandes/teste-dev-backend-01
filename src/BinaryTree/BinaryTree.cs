namespace Owner.BinaryTree
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> RootNode { get; set; }

        public BinaryTree(BinaryTreeNode<T> rootNode)
        {
            RootNode = rootNode;
        }
    }
}
