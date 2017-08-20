import React from 'react'

const Drawer = (props) => {
  const getRow = (linkArr, i) => {
    return <a key={i} className="menu-link" href={linkArr[0]}>{linkArr[1]}</a>
  }

  return (
    <div className="drawer">
      <nav className="menu">
        {props.links.map((linkArr, i) => getRow(linkArr, i))}
      </nav>
    </div>
  )
}

export default Drawer;