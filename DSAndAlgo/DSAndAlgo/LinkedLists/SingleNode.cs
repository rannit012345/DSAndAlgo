namespace DSAndAlgo.LinkedLists
{
    //Better to create generic node
    class SingleNode
    {
        public object data;
        public SingleNode next;

        public SingleNode(object val)
        {
            data = val;
            next = null;
        }
    }
}
