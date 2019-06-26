import React from 'react'
import Tree from 'react-d3-tree'

const data = {
  name: 'vscode.task.generator',
  description: 'generate task implementation',
  tasks: [
    {
      loadProjectItem: {
        name: 'loadCSharpTasks',
        projectName: "$this equals 'Ultramarine.Generators.Tasks'",
        typeOf: 'Task'
      }
    },
    {
      loadCodeElement: {
        name: 'loadCSharpTask',
        connectedWith: 'loadCSharpTasks2',
        elementType: 'class',
        typeOf: 'Task'
      }
    },
    {
      iterator: {
        name: 'foreachCSharpt',
        connectedWith: 'loadCSharpTaskClasses',
        tasks: [
          {
            readProperty: {
              name: 'readTaskName',
              propertyName: 'Name',
              typeOf: 'Task2'
            }
          },
          {
            setVariable: {
              name: 'setTaskName',
              description: '',
              variableName: 'TaskName',
              connectedWith: 'readTaskName',
              typeOf: 'Task2'
            }
          },
          {
            textTransformation: {
              name: 'transformToEs6',
              fileName: "$this equals 'TransformTask.tt'",
              projectName: "$this equals 'Ultramarine.GeneratorRecipes'",
              typeOf: 'Task2'
            }
          },
          {
            createProjectItem: {
              name: 'createTaskItem',
              connectedWith: 'transformToEs6',
              itemName: '{TaskName}.generated.js',
              folderPath: 'src\\vivaldi\\components\\tasks\\generated',
              typeOf: 'Task2',
              overwrite: true
            }
          },
          {
            iterator: {
              name: 'foreachCSharptTask',
              connectedWith: 'loadCSharpTaskClasses',
              tasks: [
                {
                  readPropertySecond: {
                    name: 'readTaskName',
                    propertyName: 'Name',
                    typeOf: 'Task3'
                  }
                },
                {
                  setVariableSecond: {
                    name: 'setTaskName',
                    description: '',
                    variableName: 'TaskName',
                    connectedWith: 'readTaskName',
                    typeOf: 'Task3'
                  }
                }
              ]
            }
          }
        ]
      }
    }
  ]
}

const MyTree = () => {
  const nodeSvgShape = {
    shape: 'rect',
    shapeProps: {
      width: 20,
      height: 20,
      x: -10,
      y: -10,
      fill: 'red'
    }
  }

  const blue = '#337ab7'
  const green = '#5cb85c'
  const yellow = '#f0ad4e'
  const purple = '#9467bd'
  const grey = '	#D0D0D0'

  const formatColorsOfNodes = type => {
    let color = null

    switch (type) {
      case 'Task':
        color = blue
        break
      case 'Task2':
        color = green
        break
      case 'Task3':
        color = purple
        break
      default:
        color = grey
        break
    }

    return {
      shape: 'rect',
      shapeProps: {
        width: 70,
        height: 40,
        x: -10,
        y: -10,
        fill: color
      }
    }
  }

  const formatedTree = {}

  function Traversal(task, newData) {
    if (newData !== undefined) {
      // eslint-disable-next-line no-param-reassign
      newData.nodeName = task.name
      // eslint-disable-next-line no-param-reassign
      newData.name = task.name
    }
    // eslint-disable-next-line no-param-reassign
    newData.children = []

    task.tasks.forEach(item => {
      const type = item[Object.keys(item)[0]]
      const childrenData = {}
      childrenData.nodeName = type.name
      childrenData.name = type.name
      // eslint-disable-next-line no-underscore-dangle
      childrenData._collapsed = true
      childrenData.nodeSvgShape = formatColorsOfNodes(type.typeOf)

      if (type.tasks !== undefined) {
        newData.children.push(childrenData)
        Traversal(
          type,
          newData.children.find(obj => obj.nodeName === childrenData.name)
        )
      } else {
        newData.children.push(childrenData)
      }
    })
  }
  Traversal(data, formatedTree)

  console.log(formatedTree)

  const clicked = (nodeData, event) => {
    console.log(nodeData)
  }

  return (
    <div
      id="treeWrapper"
      style={{ width: '150em', height: '120em', background: 'white' }}
    >
      <Tree data={formatedTree} onClick={clicked} />
    </div>
  )
}

export default MyTree
