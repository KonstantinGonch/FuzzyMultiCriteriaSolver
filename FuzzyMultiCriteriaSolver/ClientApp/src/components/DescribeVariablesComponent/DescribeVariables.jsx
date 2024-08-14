import React, { useEffect, useState } from 'react';
import { useSearchParams } from "react-router-dom";
import axios from 'axios';
import DescribeVariableItem from './VariableItem';

function DescribeVariables() {

	const [variables, setVariables] = useState([]);
	const [searchParams, setSearchParams] = useSearchParams();
	const [addingVariable, setAddingVariable] = useState(false);

	const loadVariables = () => {
		const objectiveId = searchParams.get("objectiveId");
		axios.get(`/api/variables/getObjectiveVariables/${objectiveId}`)
			.then(response => {
				setVariables(response.data)
			})
			.catch(error => {
				console.error('Error getting variables ', error);
			});
	}

	const onSaveVariable = (variable) => {
		axios.post('/api/variables/add', variable)
			.then(response => {
				loadVariables();
				setAddingVariable(false);
			})
			.catch(error => {
				console.error('Error creating objective: ', error);
			});
	}

	useEffect(() => {
		loadVariables();
	}, [])

	const onAddVariable = () => {
		setAddingVariable(true);
	}

	const getLinkToNextStep = () => {
		return `/describe-membership-functions?objectiveId=${searchParams.get("objectiveId")}`;
	}

	return (
		<div>
			<h2>Описание входных переменных</h2>
			<div class="panel panel-default">
				<div class="panel-body">
					<div className="list-group">
						{variables.map(variable => {
							return <DescribeVariableItem variable={variable} editable={false} onSaveVariable={null} objectiveId={searchParams.get("objectiveId")} />
						})}
						{addingVariable && <DescribeVariableItem editable={true} onSaveVariable={onSaveVariable} objectiveId={searchParams.get("objectiveId") } />}
						<div className="col-sm-12">
							<button className="btn btn-primary bi bi-plus-square" style={{ marginTop: '1em' }} onClick={onAddVariable} disabled={addingVariable}></button>
						</div>
					</div>
					<div className="row" style={{ marginTop: '1em' }}>
						<button className="btn btn-primary col-sm-2"><a style={{ color: 'white' }} href={getLinkToNextStep()} disabled={variables.length === 0}>Продолжить</a></button>
					</div>
				</div>
			</div>
		</div>
	);
}

export default DescribeVariables;
