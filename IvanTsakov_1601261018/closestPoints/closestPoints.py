from math import sqrt
from itertools import combinations, product
from collections import defaultdict
import sys

max_float = sys.float_info.max

def dist((x1, y1), (x2, y2)):
    return sqrt((x1 - x2) ** 2 + (y1 - y2) **2)

def closest(points_list):
    if len(points_list) < 2:
        return (max_float, None, None)  # default value compatible with min function
    return min((dist(p1, p2), p1, p2) for p1, p2 in combinations(points_list, r=2))

def closest_between(pnt_lst1, pnt_lst2):
    if not pnt_lst1 or not pnt_lst2:
        return (max_float, None, None)  # default value compatible with min function
    return min((dist(p1, p2), p1, p2)
               for p1, p2 in product(pnt_lst1, pnt_lst2))

def divide_on_tiles(points_list):
    side = int(sqrt(len(points_list)))  # number of tiles on one side of square
    tiles = defaultdict(list)
    min_x = min(x for x, y in points_list)
    max_x = max(x for x, y in points_list)
    min_y = min(x for x, y in points_list)
    max_y = max(x for x, y in points_list)
    tile_x_size = float(max_x - min_x) / side
    tile_y_size = float(max_y - min_y) / side
    for x, y in points_list:
        x_tile = int((x - min_x) / tile_x_size)
        y_tile = int((y - min_y) / tile_y_size)
        tiles[(x_tile, y_tile)].append((x, y))
    return tiles

def closest_for_tile(tiles, (x_tile, y_tile)):
    points = tiles[(x_tile, y_tile)]
    return min(closest(points),
               # use dict.get to avoid creating empty tiles
               # we compare current tile only with half of neighbours (right/top),
               # because another half (left/bottom) make it in another iteration by themselves
               closest_between(points, tiles.get((x_tile+1, y_tile))),
               closest_between(points, tiles.get((x_tile, y_tile+1))),
               closest_between(points, tiles.get((x_tile+1, y_tile+1))),
               closest_between(points, tiles.get((x_tile-1, y_tile+1))))

def find_closest_in_tiles(tiles):
    return min(closest_for_tile(tiles, coord) for coord in tiles.keys())


P1 = [(0,0),(7,6),(2,20),(12,5),(16,16),(5,8),(19,7),(14,22),(8,19),(1,89),(7,29),(10,11),(1,13),]
P2 = [(94, 5), (96, -79), (20, 73), (8, -50), (78, 2), (100, 63), (-14, -69), (99, -8), (-11, -7), (-78, -46)]

print find_closest_in_tiles(divide_on_tiles(P1)) 
print find_closest_in_tiles(divide_on_tiles(P2)) 
print find_closest_in_tiles(divide_on_tiles(P1 + P2))