/*let App = React.createClass({
  render: function () {
    return (
      <h1>Hello world!</h1> 
    )
  }
})*/

class App extends React.Component {
  render () {
    return (
      <h1>Hello world!</h1>
    )
  }
}

ReactDOM.render((<App />), document.getElementById('app'))
//React.render(<App />, document.getElementById('app'))