using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaiTapBuoi10___Cay_Nhi_Phan
{
    class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        #region them gia tri vao cay
        public void Insert(int value)
        {
            root = InsertValue(root, value);
        }

        private Node InsertValue(Node roots, int value)
        {
            if (roots == null)
            {
                roots = new Node();
                roots.Data = value;
                roots.left = null;
                roots.right = null;
                return roots;
            }
            if (value > roots.Data)
            {
                roots.right = InsertValue(roots.right, value);
            }
            else if (value < roots.Data)
            {
                roots.left = InsertValue(roots.left, value);
            }
            return roots;
        }
        #endregion

        #region inorder
        public void InOrder()
        {
            InOrderValue(root);
        }
        private void InOrderValue(Node root) 
        {
            if (root != null)
            {
                InOrderValue(root.left);
                Console.Write(root.Data + " ");
                InOrderValue(root.right);
            }
        }
        #endregion

        #region pre order
        public void PreOrder()
        {
            PreOrderValue(root);
        }
        private void PreOrderValue(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreOrderValue(root.left);
                PreOrderValue(root.right);
            }
        }
        #endregion

        #region post order
        public void PostOrder()
        {
            PostOrderValue(root);
        }
        private void PostOrderValue(Node root) //70
        {
            if (root != null)
            {
                PostOrderValue(root.left);
                PostOrderValue(root.right);
                Console.Write(root.Data + " ");
            }
        }
        #endregion

        #region tim kiem gia tri
        public void Search(int value) 
        {
            SearchValue(root, value);
        }
        private string SearchValue(Node roots, int value) 
        {
            if (roots == null) 
            {
                return "Khong ton tai cay nhi phan trong he thong";
            }
            if (value == roots.Data)
            {
                return $"Da tim thay gia tri '{value}' trong cay !";
            }
            if (value > roots.Data)
            {
                return SearchValue(roots.right, value);
            }
            else if (value < roots.Data)
            {
                return SearchValue(roots.left, value);
            }
            return "ok";
        }
        #endregion

        #region xoa gia tri
        public void Delete(int value)
        {
            root = DeleteNode(root, value);
        }

        private Node DeleteNode(Node roots, int value)
        {
            if (roots == null)
            {
                return null;
            }

            if (value < roots.Data)
            {
                roots.left = DeleteNode(roots.left, value);
            }
            else if (value > roots.Data)
            {
                roots.right = DeleteNode(roots.right, value);
            }
            else 
            {
                if (roots.left == null && roots.right == null)
                {
                    return null;
                }
                else if (roots.left == null)
                {
                    return roots.right;
                }
                else if (roots.right == null)
                {
                    return roots.left;
                }
                else
                {
                    roots.Data = TimNhoNhat(roots.right);
                    roots.right = DeleteNode(roots.right, roots.Data);
                }
            }
            return roots;
        }

        private int TimNhoNhat(Node roots)
        {
            int nhonhat = roots.Data; 
            while (roots.left != null)
            {
                nhonhat = roots.left.Data;
                roots = roots.left;
            }

            return nhonhat;
        }
        #endregion
    }
}
