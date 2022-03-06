const Graph = require('node-dijkstra')

const route = new Graph()

route.addNode('A', { C:1, E: 30, H: 10 })
route.addNode('C', { B:1 })
route.addNode('B', { })
route.addNode('E', { D:3 })
route.addNode('H', { E:30 })
route.addNode('D', { F:4 })
route.addNode('F', { I:45, G:40 })
route.addNode('I', { B:65 })
route.addNode('G', { B:64 })


console.log(route.path('A', 'I', {cost: true})) // => [ 'A', 'B', 'C', 'D' ]