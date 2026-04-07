namespace DataStructures;

public class Dynamic_Array
{
    // Đây là các Field của Class, được phép dùng public
    public int size;
    public int capacity = 10;
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

    }

    public void delete(object data)
    {

    }

    public int search(object data)
    {
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




}