import React from 'react';
import { Link } from 'react-router-dom';
import { connect } from 'react-redux';
import { userActions } from '../_actions';


class Advertisment extends React.Component {
    
    constructor(props)
    {
        super(props);
        this.state = {

            advertisment:
            {
               
            },

            submitted: false,
        };

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange(e)
    {
        const{name, value} = e.target;
        const{password} = this.state;

        this.setState({
            password:{
                ...password,
                 [name]: value 
            }
         });
    }

    handleSubmit(e)
    {
        e.preventDefault();

        this.setState({submitted: true});

        const{password} = this.state;
        const{dispatch} = this.props;
        
        if(password.newPassword === password.repeatNewPassword)
        {
            dispatch(userActions.newpass(password));
        }

    }

    render() {
        const {password, submitted} = this.state;

        return (
            <div className="col-sm-8 col-sm-offset-2">  
                
               <h2>Password Panel</h2>

               <form name="form" onSubmit={this.handleSubmit}>
               
                    <div className={'form-group' + (submitted && !(password.oldPassword) ? ' has-error' : '')}>
                        <label htmlFor="oldPassword">Current password</label>
                        <input type="password" className="form-control" name="oldPassword" value={password.oldPassword} onChange={this.handleChange} />
                        {submitted && !password.oldPassword &&
                            <div className="help-block">Password is required</div>
                        }
                    </div>

                    <div className={'form-group' + (submitted &&!(password.newPassword) ? ' has-error' : '')}>
                        <label htmlFor="newPassword">New password</label>
                        <input type="password" className="form-control" name="newPassword" value={password.newPassword} onChange={this.handleChange} />
                        {submitted && !password.newPassword &&
                            <div className="help-block">Password is required</div>
                        }
                    </div>

                    <div className={'form-group' + (submitted && (!(password.repeatNewPassword === password.newPassword) || !(password.repeatNewPassword)) ? ' has-error' : '')}>
                        <label htmlFor="repeatNewPassword">Repeat new password </label>
                        <input type="password" className="form-control" name="repeatNewPassword" value={password.repeatNewPassword} onChange={this.handleChange} />
                        {submitted && !password.repeatNewPassword &&
                            <div className="help-block">Password is required</div>
                        }
                         {submitted && !(password.newPassword === password.repeatNewPassword) && password.repeatNewPassword &&
                            <div className="help-block">Passwords must be the same</div>
                        }
                    </div>
        
                    <div className="form-group">
                        <button className="btn btn-primary">Submit</button>
                        <Link to="/" className="btn btn-link">Cancel</Link>
                    </div>
                </form>

            </div>
        );
    }
}


function mapStateToProps(state) {
    const { users, authentication } = state;
    const { user } = authentication;
    return {
        user,
        users
    };
}

const connectedAdvertisment= connect(mapStateToProps)(Advertisment);
export { connectedAdvertisment as Advertisment };