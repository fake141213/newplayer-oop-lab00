# Calculator

by Jakkraphong Samransi, 673450032-2, Computer and Infomation Science, KKU

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
var inputNum1 = num1.Text;
var inputNum2 = num2.Text;
```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```
double iNum1 = Int32.Parse(inputNum1);
double iNum2 = Int32.Parse(inputNum2);
```

### คำนวนผลลัพท์

ตัวอย่าง

```
double iResult = iNum1 + iNum2;
```

### แสดงผล

ตัวอย่าง

```
private void button1_Click(object sender, EventArgs e)
{
    var inputNum1 = num1.Text;
    var inputNum2 = num2.Text;
    double iNum1 = Int32.Parse(inputNum1);
    double iNum2 = Int32.Parse(inputNum2);
    double iResult = iNum1 + iNum2;
    result.Text = iResult.ToString();
}
```

## ปุ่มลบ
```
double iResult = iNum1 - iNum2;
```

## ปุ่มคูณ
```
double iResult = iNum1 * iNum2;
```

## ปุ่มหาร
```
double iResult = iNum1 / iNum2;
```
## ปุ่มลบข้อมูล
```
num1.Clear();
num2.Clear();
result.Clear();
```
