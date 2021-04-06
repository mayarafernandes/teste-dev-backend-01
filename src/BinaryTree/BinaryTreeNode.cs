namespace Owner.BinaryTree
{
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> LeftNode { get; set; }
        public BinaryTreeNode<T> RightNode { get; set; }
        public bool IsLeaf { get { return (LeftNode is null && RightNode is null); } }

        public BinaryTreeNode(T data, BinaryTreeNode<T> leftNode = null, BinaryTreeNode<T> rightNode = null)
        {
            Data = data;
            LeftNode = leftNode;
            RightNode = rightNode;
        }
    }
}
