#include <stdio.h>
#include <assert.h>

#include "graph.h"

#define SIZE (37)

int
main(int argc, char **argv)
{
   Graph g;

   struct list{
int x;
int y;
int z;
int x1;
int y1;
int z1;
int x2;
int y2;
int z2;
int x3;
int y3;
int z3;
} boxes[];

   int i;
   int j;

   g = graph_create(SIZE);

   
   /* fill array and graph */
   for(i = 0; i < TEST_SIZE; i++) {
printf("x1 value");
sacnf("%d\n",boxes[i].x1);
printf("y1 value");
sacnf("%d\n",boxes[i].y1);
printf("z1 value");
sacnf("%d\n",boxes[i].z1);
printf("x2 value");
sacnf("%d\n",boxes[i].x2);
printf("y2 value");
sacnf("%d\n",boxes[i].y2);
printf("z2 value");
sacnf("%d\n",boxes[i].z2);
printf("x3 value");
sacnf("%d\n",boxes[i].x3);
printf("y3 value");
sacnf("%d\n",boxes[i].y3);
printf("z3 value");
sacnf("%d\n",boxes[i].z3);

boxes[i].x = sqrt(pow(boxes[i].x1-boxes[i].x2),2)+pow((boxes[i].y1-boxes[i].y2),2)+pow((boxes[i].z1-boxes[i].z2),2));
boxes[i].y = sqrt(pow(boxes[i].x1-boxes[i].x3),2)+pow((boxes[i].y1-boxes[i].y3),2)+pow((boxes[i].z1-boxes[i].z3),2));
boxes[i].z = sqrt(pow(boxes[i].x2-boxes[i].x3),2)+pow((boxes[i].y2-boxes[i].y3),2)+pow((boxes[i].z2-boxes[i].z3),2));

for(j = 0; j < i; j++) {
           if((boxes[i].x < boxes[j].x)&&(boxes[i].y < boxes[j].y)(boxes[i].z < boxes[j].z)) graph_add_edge(g, i, j);
       }
   }


   /* free it */
   graph_destroy(g);

   return 0;
}