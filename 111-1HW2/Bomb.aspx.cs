using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW2
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //格子和炸彈位置
            char[,] ia_Map = new char[10, 10];
            int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90};

            for (int i_row = 0; i_row < ia_Map.GetLength(0); i_row++)
            {
                for (int i_list = 0; i_list < ia_Map.GetLength(1); i_list++)
                {
                    ia_Map[i_row, i_list] = '0';
                }
            }

            for (int i_ct = 0; i_ct < ia_MIndex.Length; i_ct++)
            {
                int i_row = (ia_MIndex[i_ct] / ia_Map.GetLength(1));
                int i_list=(ia_MIndex[i_ct] % ia_Map.GetLength(1));
                ia_Map[i_row, i_list] = '*';
            }

            for (int i_ct = 0; i_ct < ia_MIndex.Length; i_ct++)
            {
                int i_row = (ia_MIndex[i_ct] / ia_Map.GetLength(1));
                int i_list = (ia_MIndex[i_ct] % ia_Map.GetLength(1));
                mt_CalBombValue(ref ia_Map, i_row, i_list, ia_Map.GetLength(0), ia_Map.GetLength(1));
            }

            //印圖
            for (int i_row = 0; i_row < ia_Map.GetLength(0); i_row++)
            {
                for (int i_list = 0; i_list < ia_Map.GetLength(1); i_list++)
                {
                    Response.Write( ia_Map[i_row, i_list] );
                }
                Response.Write("<br />");
            }

            //炸彈各方向
            void mt_CalBombValue(ref char[,]ia_Map, int i_row, int i_list, int i_maxr, int i_maxl) {
                bool b_IsBomb = mt_IsBomb(ref ia_Map, i_row - 1, i_list - 1, i_maxr, i_maxl);
                if(b_IsBomb == false) 
                    mt_Addone(ref ia_Map, i_row - 1, i_list - 1);

                b_IsBomb = mt_IsBomb(ref ia_Map, i_row - 1, i_list, i_maxr, i_maxl);
                if (b_IsBomb == false)
                    mt_Addone(ref ia_Map, i_row - 1, i_list);

                b_IsBomb = mt_IsBomb(ref ia_Map, i_row + 1, i_list + 1, i_maxr, i_maxl);
                if (b_IsBomb == false)
                    mt_Addone(ref ia_Map, i_row + 1, i_list + 1);

                b_IsBomb = mt_IsBomb(ref ia_Map, i_row, i_list - 1, i_maxr, i_maxl);
                if (b_IsBomb == false)
                    mt_Addone(ref ia_Map, i_row , i_list - 1);

                b_IsBomb = mt_IsBomb(ref ia_Map, i_row , i_list + 1, i_maxr, i_maxl);
                if (b_IsBomb == false)
                    mt_Addone(ref ia_Map, i_row, i_list + 1);

                b_IsBomb = mt_IsBomb(ref ia_Map, i_row + 1, i_list - 1, i_maxr, i_maxl);
                if (b_IsBomb == false)
                    mt_Addone(ref ia_Map, i_row + 1, i_list - 1);

                b_IsBomb = mt_IsBomb(ref ia_Map, i_row + 1, i_list, i_maxr, i_maxl);
                if (b_IsBomb == false)
                    mt_Addone(ref ia_Map, i_row + 1, i_list);

                b_IsBomb = mt_IsBomb(ref ia_Map, i_row + 1, i_list + 1, i_maxr, i_maxl);
                if (b_IsBomb == false)
                    mt_Addone(ref ia_Map, i_row + 1, i_list + 1);
            }
        
            bool mt_IsBomb(ref char[,]ia_Map, int i_row, int i_list, int i_maxr, int i_maxl) {

                bool b_IsBomb = false;

                //判斷周圍是否有炸彈
                if (i_row < 0 || i_row >= i_maxr)
                {
                    b_IsBomb = true;
                    return b_IsBomb;
                }
                else if (i_list < 0 || i_list >= i_maxl)
                {
                    b_IsBomb = true;
                    return b_IsBomb;
                }
                else if (ia_Map[i_row, i_list] == '*')
                {
                    b_IsBomb = true;
                }
                return b_IsBomb;
            }

        }

            void mt_Addone(ref char[,] ia_Map, int i_row, int i_list)
        {
            int IValue = Convert.ToInt32(ia_Map[i_row, i_list]);
            IValue++;
            ia_Map[i_row, i_list] = Convert.ToChar(IValue);
        }
    }
   
}