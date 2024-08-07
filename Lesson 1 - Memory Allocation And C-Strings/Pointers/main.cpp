#include <iostream>

using namespace std;

int main( )
{
    //
    // malloc (amount of memory)
    bool* name = (bool*)malloc(sizeof(bool));

    int* preciseInt = (int*) malloc(sizeof(int)*512);

    cout << name << endl;

    free(name);

    return 0;
}