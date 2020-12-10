using System;
using System.Windows.Forms;

namespace Stocu
{
    public partial class Form1 : Form
    {
        int[,] n = new int[9, 9];
        public bool canplaceInSq(int y, int x, int su)
        {
            y /= 3;
            x /= 3;

            y *= 3;
            x *= 3;

            for (int i = y; i < y + 3; i++)
            {
                for (int j = x; j < x + 3; j++)
                {
                    if (n[i,j] == su) return false;
                }
            }
            return true;
        }
        public bool canplace(int y, int x, int su)
        {
            for (int i = 0; i < 9; i++)
            {
                if (n[y,i] == su) return false;
            }

            for (int i = 0; i < 9; i++)
            {
                if (n[i,x] == su) return false;
            }
            if (!canplaceInSq(y, x, su)) return false;
            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }
        public bool StartDfs(int Y,int X ,int cnt)
        {
            if (X == 9)
            {
                X = 0;
                Y++;
            }
            if (Y == 9)
            {
                (zerozero.Text) = Convert.ToString(n[0, 0]);
                (zeroone.Text) = Convert.ToString(n[0, 1]);
                (zerotwo.Text) = Convert.ToString(n[0, 2]);
                (zerothree.Text) = Convert.ToString(n[0, 3]);
                (zerofour.Text) = Convert.ToString(n[0, 4]);
                (zerofive.Text) = Convert.ToString(n[0, 5]);
                (zerosix.Text) = Convert.ToString(n[0, 6]);
                (zeroseven.Text) = Convert.ToString(n[0, 7]);
                (zeroeight.Text) = Convert.ToString(n[0, 8]);
                (onezero.Text) = Convert.ToString(n[1, 0]);
                (oneone.Text) = Convert.ToString(n[1, 1]);
                (onetwo.Text) = Convert.ToString(n[1, 2]);
                (onethree.Text) = Convert.ToString(n[1, 3]);
                (onefour.Text) = Convert.ToString(n[1, 4]);
                (onefive.Text) = Convert.ToString(n[1, 5]);
                (onesix.Text) = Convert.ToString(n[1, 6]);
                (oneseven.Text) = Convert.ToString(n[1, 7]);
                (oneeight.Text) = Convert.ToString(n[1, 8]);
                (twozero.Text) = Convert.ToString(n[2, 0]);
                (twoone.Text) = Convert.ToString(n[2, 1]);
                (twotwo.Text) = Convert.ToString(n[2, 2]);
                (twothree.Text) = Convert.ToString(n[2, 3]);
                (twofour.Text) = Convert.ToString(n[2, 4]);
                (twofive.Text) = Convert.ToString(n[2, 5]);
                (twosix.Text) = Convert.ToString(n[2, 6]);
                (twoseven.Text) = Convert.ToString(n[2, 7]);
                (twoeight.Text) = Convert.ToString(n[2, 8]);
                (threezero.Text) = Convert.ToString(n[3, 0]);
                (threeone.Text) = Convert.ToString(n[3, 1]);
                (threetwo.Text) = Convert.ToString(n[3, 2]);
                (threethree.Text) = Convert.ToString(n[3, 3]);
                (threefour.Text) = Convert.ToString(n[3, 4]);
                (threefive.Text) = Convert.ToString(n[3, 5]);
                (threesix.Text) = Convert.ToString(n[3, 6]);
                (threeseven.Text) = Convert.ToString(n[3, 7]);
                (threeeight.Text) = Convert.ToString(n[3, 8]);
                (fourzero.Text) = Convert.ToString(n[4, 0]);
                (fourone.Text) = Convert.ToString(n[4, 1]);
                (fourtwo.Text) = Convert.ToString(n[4, 2]);
                (fourthree.Text) = Convert.ToString(n[4, 3]);
                (fourfour.Text) = Convert.ToString(n[4, 4]);
                (fourfive.Text) = Convert.ToString(n[4, 5]);
                (foursix.Text) = Convert.ToString(n[4, 6]);
                (fourseven.Text) = Convert.ToString(n[4, 7]);
                (foureight.Text) = Convert.ToString(n[4, 8]);
                (fivezero.Text) = Convert.ToString(n[5, 0]);
                (fiveone.Text) = Convert.ToString(n[5, 1]);
                (fivetwo.Text) = Convert.ToString(n[5, 2]);
                (fivethree.Text) = Convert.ToString(n[5, 3]);
                (fivefour.Text) = Convert.ToString(n[5, 4]);
                (fivefive.Text) = Convert.ToString(n[5, 5]);
                (fivesix.Text) = Convert.ToString(n[5, 6]);
                (fiveseven.Text) = Convert.ToString(n[5, 7]);
                (fiveeight.Text) = Convert.ToString(n[5, 8]);
                (sixzero.Text) = Convert.ToString(n[6, 0]);
                (sixone.Text) = Convert.ToString(n[6, 1]);
                (sixtwo.Text) = Convert.ToString(n[6, 2]);
                (sixthree.Text) = Convert.ToString(n[6, 3]);
                (sixfour.Text) = Convert.ToString(n[6, 4]);
                (sixfive.Text) = Convert.ToString(n[6, 5]);
                (sixsix.Text) = Convert.ToString(n[6, 6]);
                (sixseven.Text) = Convert.ToString(n[6, 7]);
                (sixeight.Text) = Convert.ToString(n[6, 8]);
                (sevenzero.Text) = Convert.ToString(n[7, 0]);
                (sevenone.Text) = Convert.ToString(n[7, 1]);
                (seventwo.Text) = Convert.ToString(n[7, 2]);
                (seventhree.Text) = Convert.ToString(n[7, 3]);
                (sevenfour.Text) = Convert.ToString(n[7, 4]);
                (sevenfive.Text) = Convert.ToString(n[7, 5]);
                (sevensix.Text) = Convert.ToString(n[7, 6]);
                (sevenseven.Text) = Convert.ToString(n[7, 7]);
                (seveneight.Text) = Convert.ToString(n[7, 8]);
                (eightzero.Text) = Convert.ToString(n[8, 0]);
                (eightone.Text) = Convert.ToString(n[8, 1]);
                (eighttwo.Text) = Convert.ToString(n[8, 2]);
                (eightthree.Text) = Convert.ToString(n[8, 3]);
                (eightfour.Text) = Convert.ToString(n[8, 4]);
                (eightfive.Text) = Convert.ToString(n[8, 5]);
                (eightsix.Text) = Convert.ToString(n[8, 6]);
                (eightseven.Text) = Convert.ToString(n[8, 7]);
                (eighteight.Text) = Convert.ToString(n[8, 8]);

                
                return true;
            }
            if (n[Y, X] == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (canplace(Y, X, i))
                    {
                        n[Y, X] = i;
                        if (StartDfs(Y, X + 1 , cnt+1)) return true;
                        n[Y,X] = 0;
                    }
                }
            }
            else
            {
                return StartDfs(Y, X + 1, cnt + 1);
            }
            return false;
        }
        public void setup()
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    n[i, j] = 0;
                }
            }
            if (!string.IsNullOrWhiteSpace(zerozero.Text)) n[0, 0] = Convert.ToInt32(zerozero.Text);
            if (!string.IsNullOrWhiteSpace(zeroone.Text)) n[0, 1] = Convert.ToInt32(zeroone.Text);
            if (!string.IsNullOrWhiteSpace(zerotwo.Text)) n[0, 2] = Convert.ToInt32(zerotwo.Text);
            if (!string.IsNullOrWhiteSpace(zerothree.Text)) n[0, 3] = Convert.ToInt32(zerothree.Text);
            if (!string.IsNullOrWhiteSpace(zerofour.Text)) n[0, 4] = Convert.ToInt32(zerofour.Text);
            if (!string.IsNullOrWhiteSpace(zerofive.Text)) n[0, 5] = Convert.ToInt32(zerofive.Text);
            if (!string.IsNullOrWhiteSpace(zerosix.Text)) n[0, 6] = Convert.ToInt32(zerosix.Text);
            if (!string.IsNullOrWhiteSpace(zeroseven.Text)) n[0, 7] = Convert.ToInt32(zeroseven.Text);
            if (!string.IsNullOrWhiteSpace(zeroeight.Text)) n[0, 8] = Convert.ToInt32(zeroeight.Text);
            if (!string.IsNullOrWhiteSpace(onezero.Text)) n[1, 0] = Convert.ToInt32(onezero.Text);
            if (!string.IsNullOrWhiteSpace(oneone.Text)) n[1, 1] = Convert.ToInt32(oneone.Text);
            if (!string.IsNullOrWhiteSpace(onetwo.Text)) n[1, 2] = Convert.ToInt32(onetwo.Text);
            if (!string.IsNullOrWhiteSpace(onethree.Text)) n[1, 3] = Convert.ToInt32(onethree.Text);
            if (!string.IsNullOrWhiteSpace(onefour.Text)) n[1, 4] = Convert.ToInt32(onefour.Text);
            if (!string.IsNullOrWhiteSpace(onefive.Text)) n[1, 5] = Convert.ToInt32(onefive.Text);
            if (!string.IsNullOrWhiteSpace(onesix.Text)) n[1, 6] = Convert.ToInt32(onesix.Text);
            if (!string.IsNullOrWhiteSpace(oneseven.Text)) n[1, 7] = Convert.ToInt32(oneseven.Text);
            if (!string.IsNullOrWhiteSpace(oneeight.Text)) n[1, 8] = Convert.ToInt32(oneeight.Text);
            if (!string.IsNullOrWhiteSpace(twozero.Text)) n[2, 0] = Convert.ToInt32(twozero.Text);
            if (!string.IsNullOrWhiteSpace(twoone.Text)) n[2, 1] = Convert.ToInt32(twoone.Text);
            if (!string.IsNullOrWhiteSpace(twotwo.Text)) n[2, 2] = Convert.ToInt32(twotwo.Text);
            if (!string.IsNullOrWhiteSpace(twothree.Text)) n[2, 3] = Convert.ToInt32(twothree.Text);
            if (!string.IsNullOrWhiteSpace(twofour.Text)) n[2, 4] = Convert.ToInt32(twofour.Text);
            if (!string.IsNullOrWhiteSpace(twofive.Text)) n[2, 5] = Convert.ToInt32(twofive.Text);
            if (!string.IsNullOrWhiteSpace(twosix.Text)) n[2, 6] = Convert.ToInt32(twosix.Text);
            if (!string.IsNullOrWhiteSpace(twoseven.Text)) n[2, 7] = Convert.ToInt32(twoseven.Text);
            if (!string.IsNullOrWhiteSpace(twoeight.Text)) n[2, 8] = Convert.ToInt32(twoeight.Text);
            if (!string.IsNullOrWhiteSpace(threezero.Text)) n[3, 0] = Convert.ToInt32(threezero.Text);
            if (!string.IsNullOrWhiteSpace(threeone.Text)) n[3, 1] = Convert.ToInt32(threeone.Text);
            if (!string.IsNullOrWhiteSpace(threetwo.Text)) n[3, 2] = Convert.ToInt32(threetwo.Text);
            if (!string.IsNullOrWhiteSpace(threethree.Text)) n[3, 3] = Convert.ToInt32(threethree.Text);
            if (!string.IsNullOrWhiteSpace(threefour.Text)) n[3, 4] = Convert.ToInt32(threefour.Text);
            if (!string.IsNullOrWhiteSpace(threefive.Text)) n[3, 5] = Convert.ToInt32(threefive.Text);
            if (!string.IsNullOrWhiteSpace(threesix.Text)) n[3, 6] = Convert.ToInt32(threesix.Text);
            if (!string.IsNullOrWhiteSpace(threeseven.Text)) n[3, 7] = Convert.ToInt32(threeseven.Text);
            if (!string.IsNullOrWhiteSpace(threeeight.Text)) n[3, 8] = Convert.ToInt32(threeeight.Text);
            if (!string.IsNullOrWhiteSpace(fourzero.Text)) n[4, 0] = Convert.ToInt32(fourzero.Text);
            if (!string.IsNullOrWhiteSpace(fourone.Text)) n[4, 1] = Convert.ToInt32(fourone.Text);
            if (!string.IsNullOrWhiteSpace(fourtwo.Text)) n[4, 2] = Convert.ToInt32(fourtwo.Text);
            if (!string.IsNullOrWhiteSpace(fourthree.Text)) n[4, 3] = Convert.ToInt32(fourthree.Text);
            if (!string.IsNullOrWhiteSpace(fourfour.Text)) n[4, 4] = Convert.ToInt32(fourfour.Text);
            if (!string.IsNullOrWhiteSpace(fourfive.Text)) n[4, 5] = Convert.ToInt32(fourfive.Text);
            if (!string.IsNullOrWhiteSpace(foursix.Text)) n[4, 6] = Convert.ToInt32(foursix.Text);
            if (!string.IsNullOrWhiteSpace(fourseven.Text)) n[4, 7] = Convert.ToInt32(fourseven.Text);
            if (!string.IsNullOrWhiteSpace(foureight.Text)) n[4, 8] = Convert.ToInt32(foureight.Text);
            if (!string.IsNullOrWhiteSpace(fivezero.Text)) n[5, 0] = Convert.ToInt32(fivezero.Text);
            if (!string.IsNullOrWhiteSpace(fiveone.Text)) n[5, 1] = Convert.ToInt32(fiveone.Text);
            if (!string.IsNullOrWhiteSpace(fivetwo.Text)) n[5, 2] = Convert.ToInt32(fivetwo.Text);
            if (!string.IsNullOrWhiteSpace(fivethree.Text)) n[5, 3] = Convert.ToInt32(fivethree.Text);
            if (!string.IsNullOrWhiteSpace(fivefour.Text)) n[5, 4] = Convert.ToInt32(fivefour.Text);
            if (!string.IsNullOrWhiteSpace(fivefive.Text)) n[5, 5] = Convert.ToInt32(fivefive.Text);
            if (!string.IsNullOrWhiteSpace(fivesix.Text)) n[5, 6] = Convert.ToInt32(fivesix.Text);
            if (!string.IsNullOrWhiteSpace(fiveseven.Text)) n[5, 7] = Convert.ToInt32(fiveseven.Text);
            if (!string.IsNullOrWhiteSpace(fiveeight.Text)) n[5, 8] = Convert.ToInt32(fiveeight.Text);
            if (!string.IsNullOrWhiteSpace(sixzero.Text)) n[6, 0] = Convert.ToInt32(sixzero.Text);
            if (!string.IsNullOrWhiteSpace(sixone.Text)) n[6, 1] = Convert.ToInt32(sixone.Text);
            if (!string.IsNullOrWhiteSpace(sixtwo.Text)) n[6, 2] = Convert.ToInt32(sixtwo.Text);
            if (!string.IsNullOrWhiteSpace(sixthree.Text)) n[6, 3] = Convert.ToInt32(sixthree.Text);
            if (!string.IsNullOrWhiteSpace(sixfour.Text)) n[6, 4] = Convert.ToInt32(sixfour.Text);
            if (!string.IsNullOrWhiteSpace(sixfive.Text)) n[6, 5] = Convert.ToInt32(sixfive.Text);
            if (!string.IsNullOrWhiteSpace(sixsix.Text)) n[6, 6] = Convert.ToInt32(sixsix.Text);
            if (!string.IsNullOrWhiteSpace(sixseven.Text)) n[6, 7] = Convert.ToInt32(sixseven.Text);
            if (!string.IsNullOrWhiteSpace(sixeight.Text)) n[6, 8] = Convert.ToInt32(sixeight.Text);
            if (!string.IsNullOrWhiteSpace(sevenzero.Text)) n[7, 0] = Convert.ToInt32(sevenzero.Text);
            if (!string.IsNullOrWhiteSpace(sevenone.Text)) n[7, 1] = Convert.ToInt32(sevenone.Text);
            if (!string.IsNullOrWhiteSpace(seventwo.Text)) n[7, 2] = Convert.ToInt32(seventwo.Text);
            if (!string.IsNullOrWhiteSpace(seventhree.Text)) n[7, 3] = Convert.ToInt32(seventhree.Text);
            if (!string.IsNullOrWhiteSpace(sevenfour.Text)) n[7, 4] = Convert.ToInt32(sevenfour.Text);
            if (!string.IsNullOrWhiteSpace(sevenfive.Text)) n[7, 5] = Convert.ToInt32(sevenfive.Text);
            if (!string.IsNullOrWhiteSpace(sevensix.Text)) n[7, 6] = Convert.ToInt32(sevensix.Text);
            if (!string.IsNullOrWhiteSpace(sevenseven.Text)) n[7, 7] = Convert.ToInt32(sevenseven.Text);
            if (!string.IsNullOrWhiteSpace(seveneight.Text)) n[7, 8] = Convert.ToInt32(seveneight.Text);
            if (!string.IsNullOrWhiteSpace(eightzero.Text)) n[8, 0] = Convert.ToInt32(eightzero.Text);
            if (!string.IsNullOrWhiteSpace(eightone.Text)) n[8, 1] = Convert.ToInt32(eightone.Text);
            if (!string.IsNullOrWhiteSpace(eighttwo.Text)) n[8, 2] = Convert.ToInt32(eighttwo.Text);
            if (!string.IsNullOrWhiteSpace(eightthree.Text)) n[8, 3] = Convert.ToInt32(eightthree.Text);
            if (!string.IsNullOrWhiteSpace(eightfour.Text)) n[8, 4] = Convert.ToInt32(eightfour.Text);
            if (!string.IsNullOrWhiteSpace(eightfive.Text)) n[8, 5] = Convert.ToInt32(eightfive.Text);
            if (!string.IsNullOrWhiteSpace(eightsix.Text)) n[8, 6] = Convert.ToInt32(eightsix.Text);
            if (!string.IsNullOrWhiteSpace(eightseven.Text)) n[8, 7] = Convert.ToInt32(eightseven.Text);
            if (!string.IsNullOrWhiteSpace(eighteight.Text)) n[8, 8] = Convert.ToInt32(eighteight.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setup();
            StartDfs(0, 0 , 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
