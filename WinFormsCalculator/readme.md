# Calculator

by Tanapattara Wongkhamchan, 673450032-2, Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
private void button1_Click(object sender, EventArgs e)
{
    // ข้อความตัวอักษร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    // int ทำให้เราสามารถทำการ + - * / ได้
    int iResult = iNum1 + iNum2;
    // ที่ตัวแปรชื่อ result
    // มีคุณสมบัติชื่อ Text
    result.Text = iResult.ToString();
}
```

### รับข้อมูล

ตัวอย่าง

```

```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```

```

### คำนวนผลลัพท์

ตัวอย่าง

```

```

### แสดงผล

ตัวอย่าง

```

```

## ปุ่มลบ

## ปุ่มคูณ

## ปุ่มหาร

## ปุ่มลบข้อมูล

