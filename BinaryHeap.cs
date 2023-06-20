public BinaryHeap insert(int value , BinaryHeap node , int count)
    {

        //1. Insert into a binary tree breadth wise( satisfy complete binary property) (left to right)
        //2. Once inserted ,fix the tree by running heapify every time a new value(non duplicate) is added.
        //3. Count represents the total no of elements in the tree. Calculate the total no of parents for given set of elements.

         int parent = (count - 1)/2;

        if (node == null)
        {
            node = new BinaryHeap();
            node.data = value;


        }

            else
        {
            if (((parent == 0) && (node.left == null)) || (parent % 2 == 1))
            {


                node.left = insert(value, node.left, parent);
                Debug.Assert(node.left != null); 
                node.left.parent = node;
                Heapify(node.left);
                if (node.right != null) // if both left and right sub tree are filled
                {
                    Debug.Assert(node.data < node.left.data && node.data < node.right.data);// heapified node  will be minimum
                }
                else // incomplete subtree withh right subtree not filled.
                {
                    Debug.Assert(node.data < node.left.data);
                }
            }

            else
            {
                Debug.Assert(node.left != null); 
                node.right = insert(value, node.right, parent);
                Debug.Assert(node.right != null); 
                node.right.parent = node;

                Heapify(node.right);
                if (node.left != null) // if both left and right sub tree are filled
                {
                    Debug.Assert(node.data < node.left.data && node.data < node.right.data);// heapified node  will be minimum
                }
                else // incomplete sub tree with right sub tree not filled.
                {
                    Debug.Assert(node.data < node.right.data);
                }

            }
        }// end of else
        // every time you add an element you run heapify to rearrange the nodes.

        return node;
    }

    public void Heapify(BinaryHeap node)

    { 
   //Bubble up until you are unable to
        if (node == null)
        {
            return;
        }

        else
        {

            if (node.parent != null && node.parent.data > node.data)
            {
                //swap the value
                int temp = node.parent.data;
                node.parent.data = node.data;
                node.data = temp;
                node = node.parent;
                Heapify(node.parent);
                return;
            }
    }
  }// end of function heapify
