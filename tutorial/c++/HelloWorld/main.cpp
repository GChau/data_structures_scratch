#include <iostream>

int main(int argc, char const *argv[])
{
    std::cout << "Good Mornin' Sunshine!" << std::endl;
    if (argc > 1) {
        std::cout << "I was compiled with " << argv[1] << "." << std::endl;
    }
    return 0;
}