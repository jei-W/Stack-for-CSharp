using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        int count = 0;
        int[] stack;

        //생성자에서 저장공간 설정가능
        //배열 이용
        public Stack( int arg )
        {
            stack = new int[arg];
        }

        //Resize 저장공간 변경가능
        public void Resize( int arg )
        {
            Array.Resize(ref stack, arg);
            if( count > stack.Length )
                count = stack.Length;
        }

        //Push
        public void Push( int value )
        {
            if( IsFull() )
            {
                Console.WriteLine("더 이상 값을 넣을 수 없습니다.");
                System.Threading.Thread.Sleep(700);
                return;
            }
            stack[count] = value;
            ++count;
        }

        //Pop
        public int Pop()
        {
            if( IsEmpty() )
            {
                Console.WriteLine("저장된 값이 없습니다.");
                System.Threading.Thread.Sleep(700);
                return 0;
            }
            int i = stack[count - 1];
            Array.Clear(stack, count - 1, 1);
            --count;
            return i;
        }

        //IsEmpty
        public bool IsEmpty()
        {
            if( count == 0 )
                return true;
            return false;
        }

        //IsFull
        public bool IsFull()
        {
            if( count == stack.Length )
                return true;
            return false;
        }

        //Print
        public void Print()
        {
            foreach( int i in stack )
            {
                Console.Write($"{i} ");
            }
        }

        //Clear
        public void Clear()
        {
            Array.Clear(stack, 0, count);
            count = 0;
        }
    }
}
