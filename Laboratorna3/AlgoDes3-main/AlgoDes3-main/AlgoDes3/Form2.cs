using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections.Generic;

namespace AlgoDes3
{
    public partial class Form2 : Form
    {
        private AVLTree avlTree;

        public Form2(AVLTree avlTree)
        {
            this.avlTree = avlTree;
            InitializeComponent();
        }

        private void DrawTree(Graphics g, AVLNode node, int x, int y, int xOffset, int levelHeight)
        {
            if (node == null)
                return;

            // Властивості вузла
            int nodeDiameter = 40;
            int radius = nodeDiameter / 2;

            // Координати вузла
            int nodeX = x - radius;
            int nodeY = y - radius;

            // Малюємо лінії до дочірніх вузлів
            if (node.Left != null)
            {
                int leftX = x - xOffset / 2;
                int leftY = y + levelHeight;
                g.DrawLine(Pens.Black, x, y, leftX, leftY);
                DrawTree(g, node.Left, leftX, leftY, xOffset / 2, levelHeight);
            }
            if (node.Right != null)
            {
                int rightX = x + xOffset / 2;
                int rightY = y + levelHeight;
                g.DrawLine(Pens.Black, x, y, rightX, rightY);
                DrawTree(g, node.Right, rightX, rightY, xOffset / 2, levelHeight);
            }

            // Малюємо вузол як коло
            g.FillEllipse(Brushes.LightBlue, nodeX, nodeY, nodeDiameter, nodeDiameter);
            g.DrawEllipse(Pens.Black, nodeX, nodeY, nodeDiameter, nodeDiameter);

            // Малюємо ключ вузла в центрі
            string keyText = node.Key.ToString();
            SizeF textSize = g.MeasureString(keyText, SystemFonts.DefaultFont);
            float textX = x - textSize.Width / 2;
            float textY = y - textSize.Height / 2;
            g.DrawString(keyText, SystemFonts.DefaultFont, Brushes.Black, textX, textY);
        }


        public int TreeHeight(AVLNode avlRoot)
        {
            if (avlRoot != null)
                return 1 + Math.Max(TreeHeight(avlRoot.Left), TreeHeight(avlRoot.Right));
            return 0;
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            
            int treeHeight = TreeHeight(avlTree.Root);
            
            int panelWidth = panel1.Width;
            int nodeLevelHeight = 60;
            int initialX = panelWidth / 2;
            int initialY = 20;
            int initialOffset = (int)Math.Pow(2, treeHeight - 1) * 20;

            DrawTree(g, avlTree.Root, initialX, initialY, initialOffset, nodeLevelHeight);
        }
        

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            panel1.Invalidate(); 
            panel1.Paint += panel1_Paint;
        }
    }
}
