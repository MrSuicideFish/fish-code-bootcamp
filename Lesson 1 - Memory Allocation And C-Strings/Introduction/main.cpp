#include <iostream>

using namespace std;

// Layers
// --------
// Kernel
// Operating System (Windows)
// Application

int strLen(const char* value)
{
    int result = 0;
    int index = 0;
    while (value[index] != '\0')
    {
        result++;
    }

    return result;
}

class Map
{
    private:
        int foo;
        bool foo;
        float foo;

        // always 64-bit
        float* foo;
        int* foo;
        char* foo;
};

int main( )
{
    // c-style strings
    // allocate some memory
    char cstyle[] = "C-Style String";
    char* intro = (char*)malloc(sizeof(char)*30);
    Map* intro = (Map*)malloc(sizeof(Map)*30);

    // doesn't work
    //intro = "Hello, World!";

    // do this instead!
    const char* source = "Hello, World!";
    strcpy_s(intro, strlen(source)+1, source);

    cout << intro << endl;
    free(intro);
    return 0;
}