#include<iostream>
using namespace std;

int main(){
    unsigned long m, n, a;
    cin >> n >> m >> a;

    unsigned long rt = n%a == 0 ? n/a : (n/a) + 1;
    unsigned long ct = m%a == 0 ? m/a : (m/a) + 1;

    unsigned long long ans = rt * ct;
    cout << ans << endl;
    return 0;
}
