namespace DataStructures;

public class Dynamic_Array
{
    // Đây là các Field của Class, được phép dùng public
    public int size;
    public int capacity = 4;
    public object[] a;

    public Dynamic_Array()
    {
        this.a = new object[capacity];
    }

    public Dynamic_Array(int capacity)
    {
        this.capacity = capacity;
        this.a = new object[capacity];
    }

    public void add(object data)
    {
        if (size >= capacity)
        {
            grow();
        }
        a[size] = data;
        size++;
    }

    public void insert(int index, object data)
    {
        if (size >= capacity)
        {
            grow();
        }
        for (int i = size; i > index; i--)
        {
            a[i] = a[i - 1];
        }
        a[index] = data;
        size++;
    }

    public void delete(object data)
    {
        for (int i = 0; i < size; i++)
        {
            if (a[i] == data)
            {
                for (int j = 0; j < (size - i - 1); j++)
                {
                    a[i + j] = a[i + j + 1];
                }
                a[size - 1] = null;
                size--;
                if (size <= (int)(capacity / 3))
                {
                    shrink();
                }
                break;
            }
        }
    }

    public int search(object data)
    {
        for (int i = 0; i < size; i++)
        {
            if (a[i] == data)
            {
                return i;
            }
        }
        return -1;
    }

    private void grow()
    {

    }

    private void shrink()
    {

    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    //public bool IsEmpty => size == 0; //property




    ////sẽ in ra A, B, C,  nhìn rất thiếu chuyên nghiệp

    //public override string ToString()
    //{
    //    string str = "";
    //    for (int i = 0; i < size; i++)
    //    {
    //        str += a[i] + ", ";
    //    }
    //    return str;
    //}

    //cái này fix cái trên


    public override string ToString()
    {
        string str = "";
        for (int i = 0; i < size; i++)
        {
            str += a[i] + ", ";
        }

        if (str != "")
        {
            // Loại bỏ dấu phẩy và khoảng trắng cuối cùng, rồi bọc trong ngoặc vuông
            str = "[" + str.Substring(0, str.Length - 2) + "]";
        }
        else
        {
            str = "[]"; // Trả về ngoặc rỗng nếu mảng không có gì
        }

        return str;
    }



    //cái này cho capacity, xem toàn bộ để thấy là nó có null hay không

    //public override string ToString()
    //{
    //    string str = "";
    //    for (int i = 0; i < capacity; i++)
    //    {
    //        // Kiểm tra nếu ô đó rỗng thì cộng chữ "null", nếu có thì cộng giá trị
    //        str += (a[i] == null ? "null" : a[i].ToString()) + ", ";
    //    }

    //    if (str != "")
    //    {
    //        // Chỉ bọc ngoặc vuông và cắt dấu phẩy cuối cùng
    //        return "[" + str.Substring(0, str.Length - 2) + "]";
    //    }
    //    return "[]";
    //}

}