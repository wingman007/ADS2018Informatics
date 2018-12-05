import itertools

list_for_routes = [7, 0, 1, 0, 2, 4, 2, 4, 2, 3, 3, 1, 4, 3]

#list 2 for test if you want to try with something different it will work with w/e list you choose
# list_for_routes=[4, 2, 3, 4, 5, 6, 8, 1, 2, 3, 4, 5]
print len(list_for_routes)
routes = set()
# using set to ignore the same pairs for example [(5,5) , (5,5)]
# this will combine every element in the list with the others in pairs
for i in itertools.combinations(list_for_routes,2):
    routes.add(i) 
    
#excluding the equal for example[(1,1),(2,2),(3,3),...etc]
# I'm using a copy of the routes set because you can't iterate over the real one and make changes on it.
for item in list(routes):
    if item[0]==item[1]:
        routes.remove(item)

print list(routes)
print len(routes)

