public class Solution {
    public bool Solve(int i, int minJump, int maxJump, string s, AVLTree tree)
{
   if (i >= s.Length - 1)
       return i == s.Length - 1;
   var maxStep = Math.Min(s.Length - 1, i + maxJump);
   while (!tree.IsEmpty() && i + minJump <= maxStep)
   {
       var step = tree.Search(i + minJump);
       if (step > maxStep)
           break;
       tree.Delete(step);
       if (Solve(step, minJump, maxJump, s, tree))
           return true;
   }
   return false;
}
public bool CanReach(string s, int minJump, int maxJump)
{
    AVLTree tree = new AVLTree();

    for (int i = 1; i < s.Length; i++)
        if (s[i] == '0')
            tree.Insert(i);
    return Solve(0, minJump, maxJump, s, tree);
}
    public class AVLTreeNode
{
    public int Key;
    public int Height;
    public AVLTreeNode Left;
    public AVLTreeNode Right;

    public AVLTreeNode(int key)
    {
        Key = key;
        Height = 1;
    }
}

public class AVLTree
{
    private AVLTreeNode root;

    // Get height of node
    private int Height(AVLTreeNode node)
    {
        if (node == null)
            return 0;
        return node.Height;
    }

    // Get balance factor of node
    private int GetBalance(AVLTreeNode node)
    {
        if (node == null)
            return 0;
        return Height(node.Left) - Height(node.Right);
    }

    // Rotate right subtree rooted with y
    private AVLTreeNode RotateRight(AVLTreeNode y)
    {
        AVLTreeNode x = y.Left;
        AVLTreeNode T2 = x.Right;

        // Perform rotation
        x.Right = y;
        y.Left = T2;

        // Update heights
        y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
        x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

        // Return new root
        return x;
    }

    // Rotate left subtree rooted with x
    private AVLTreeNode RotateLeft(AVLTreeNode x)
    {
        AVLTreeNode y = x.Right;
        AVLTreeNode T2 = y.Left;

        // Perform rotation
        y.Left = x;
        x.Right = T2;

        // Update heights
        x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
        y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

        // Return new root
        return y;
    }

    // Insert a key into the tree
    public void Insert(int key)
    {
        root = InsertRec(root, key);
    }

    private AVLTreeNode InsertRec(AVLTreeNode node, int key)
    {
        // Perform the normal BST insertion
        if (node == null)
            return new AVLTreeNode(key);

        if (key < node.Key)
            node.Left = InsertRec(node.Left, key);
        else if (key > node.Key)
            node.Right = InsertRec(node.Right, key);
        else // Duplicate keys not allowed
            return node;

        // Update height of this ancestor node
        node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));

        // Get the balance factor of this ancestor node to check whether this node became unbalanced
        int balance = GetBalance(node);

        // If this node becomes unbalanced, then there are 4 cases

        // Left Left Case
        if (balance > 1 && key < node.Left.Key)
            return RotateRight(node);

        // Right Right Case
        if (balance < -1 && key > node.Right.Key)
            return RotateLeft(node);

        // Left Right Case
        if (balance > 1 && key > node.Left.Key)
        {
            node.Left = RotateLeft(node.Left);
            return RotateRight(node);
        }

        // Right Left Case
        if (balance < -1 && key < node.Right.Key)
        {
            node.Right = RotateRight(node.Right);
            return RotateLeft(node);
        }

        // return the (unchanged) node pointer
        return node;
    }

    // Search for a key in the tree
    public int Search(int key)
    {
        return SearchRec(root, key);
    }

    private int SearchRec(AVLTreeNode node, int key)
    {
        if (node == null)
            return -1;

        if (node.Key == key)
            return key;

        int value;
        if (node.Key < key)
            value = SearchRec(node.Right, key);
        else
            value = SearchRec(node.Left, key);

        if (value == key)
            return value;

        if (value > key && node.Key > key)
            return Math.Min(value, node.Key);

        return Math.Max(value, node.Key);
    }

    // Delete a key in the tree
    public void Delete(int key)
    {
        root = DeleteRec(root, key);
    }
    public bool IsEmpty()
    {
        return root is null;
    }

    private AVLTreeNode DeleteRec(AVLTreeNode node, int key)
    {
        // Perform standard BST delete
        if (node == null)
            return node;

        // If the key to be deleted is smaller than the node's key, then it lies in left subtree
        if (key < node.Key)
            node.Left = DeleteRec(node.Left, key);

        // If the key to be deleted is greater than the node's key, then it lies in right subtree
        else if (key > node.Key)
            node.Right = DeleteRec(node.Right, key);

        // If key is same as node's key, then this is the node to be deleted
        else
        {
            // Node with only one child or no child
            if (node.Left == null || node.Right == null)
            {
                AVLTreeNode temp = node.Left ?? node.Right;

                // No child case
                if (temp == null)
                {
                    temp = node;
                    node = null;
                }
                else // One child case
                    node = temp; // Copy the contents of the non-empty child

                temp = null;
            }
            else
            {
                // Node with two children: Get the inorder successor (smallest in the right subtree)
                AVLTreeNode temp = MinValueNode(node.Right);

                // Copy the inorder successor's data to this node
                node.Key = temp.Key;

                // Delete the inorder successor
                node.Right = DeleteRec(node.Right, temp.Key);
            }
        }

        // If the tree had only one node, then return
        if (node == null)
            return node;

        // Update the height of the current node
        node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));

        // Get the balance factor of this node to check whether this node became unbalanced
        int balance = GetBalance(node);

        // If this node becomes unbalanced, then there are 4 cases

        // Left Left Case
        if (balance > 1 && GetBalance(node.Left) >= 0)
            return RotateRight(node);

        // Left Right Case
        if (balance > 1 && GetBalance(node.Left) < 0)
        {
            node.Left = RotateLeft(node.Left);
            return RotateRight(node);
        }

        // Right Right Case
        if (balance < -1 && GetBalance(node.Right) <= 0)
            return RotateLeft(node);

        // Right Left Case
        if (balance < -1 && GetBalance(node.Right) > 0)
        {
            node.Right = RotateRight(node.Right);
            return RotateLeft(node);
        }

        return node;
    }

    // Get the node with the minimum key value from a subtree
    private AVLTreeNode MinValueNode(AVLTreeNode node)
    {
        AVLTreeNode current = node;

        // Loop down to find the leftmost leaf
        while (current.Left != null)
            current = current.Left;

        return current;
    }


}
}