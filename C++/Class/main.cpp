#include <iostream>
#include <string>
using std::string;
class Person {
protected:
    string name;
    int age;

public:
    Person(string name, int age) : name(name), age(age) {}

    virtual void displayInfo() {
        std::cout << "Name: " << name << ", Age: " << age << std::endl;
    }

};

class Student : public Person {
public:
    Student(string name, int age, int studentNumber)
        : Person(name, age), studentNumber(studentNumber) {}

    void displayInfo() override {
        Person::displayInfo();
        std::cout << "Student Number: " << studentNumber << std::endl;
    }

private:
    int studentNumber;
};

class Teacher : public Person {
public:
    Teacher(string name, int age, string taughtSubject)
        : Person(name, age), taughtSubject(taughtSubject) {}

    void displayInfo() override {
        Person::displayInfo();
        std::cout << "Teaches: " << taughtSubject << std::endl;
    }

private:
    std::string taughtSubject;
};

int main() {
    Person person("John", 30);
    Student student("Alice", 20, 12345);
    Teacher teacher("Mr. Smith", 40, "Mathematics");

    std::cout << "Person Info:" << std::endl;
    person.displayInfo();

    std::cout << "\nStudent Info:" << std::endl;
    student.displayInfo();

    std::cout << "\nTeacher Info:" << std::endl;
    teacher.displayInfo();

    return 0;
}
