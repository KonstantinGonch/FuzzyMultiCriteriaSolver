import React, { useState } from 'react';
import axios from 'axios';
import Modal from '../ModalComponent/Modal';

function DescribeObjective() {
    const [title, setTitle] = useState('');
    const [description, setDescription] = useState('');
    const [isSaved, setIsSaved] = useState(false);
    const [modalOpen, setModalOpen] = useState(false);

    const handleSubmit = (event) => {
        event.preventDefault();

        const objective = {
            title: title,
            description: description
        };

        axios.post('/api/objectives/add', objective)
            .then(response => {
                setIsSaved(true);
                setModalOpen(true);
            })
            .catch(error => {
                console.error('Error creating objective: ', error);
            });
    };

    const handleModalClose = (event) => {
        event.preventDefault();

        setModalOpen(false);
	}

    return (
        <div>
            <h2>Создание задачи</h2>
            <form onSubmit={handleSubmit}>
                <div className="form-group">
                    <label className="form-label">Заголовок</label>
                    <input className="form-control" type="text" value={title} onChange={e => setTitle(e.target.value)} />
                </div>
                <div className="form-group">
                    <label className="form-label">Описание</label>
                    <textarea className="form-control" rows="3" className="form-control" type="text" value={description} onChange={e => setDescription(e.target.value)} />
                </div>
                <div className="form-group" style={{ marginTop: "1em" }}>
                    <button className="btn btn-primary" type="submit" disabled={isSaved}>Создать</button>
                </div>
            </form>
            <div className="form-group" style={{ marginTop: "1em" }}>
                <button className="btn btn-primary" disabled={!isSaved}>Продолжить</button>
            </div>
            <Modal isOpen={modalOpen} onClose={handleModalClose}>
                <>
                    <h1>Сохранено!</h1>
                </>
            </Modal>
        </div>
    );
}

export default DescribeObjective;
