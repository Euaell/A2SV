def main():
    Arr = input().split()
    M = int(Arr[0])
    N = int(Arr[1])
    print(domino(M, N))
def domino(M, N):
    return (M * N) // 2
main()
