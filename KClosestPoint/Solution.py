class Solution:
    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
        dis = defaultdict(list)
        xn=[]
        for point in points:
            d = (point[0]**2+point[1]**2)**0.5
            dis[d].append(point)
            
        sorted(dis.keys())
        for i in sorted(dis.keys()):
            for j in dis[i]:
                if k >0:
                    xn.append(j)
                    k=k-1
                else:
                    break
        return xn            